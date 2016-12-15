/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import java.io.File;
import java.net.URL;
import java.text.DateFormat;
import java.text.NumberFormat;
import java.util.Date;
import java.util.ResourceBundle;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.beans.property.ReadOnlyObjectWrapper;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.css.PseudoClass;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.TreeItem;
import javafx.scene.control.TreeTableCell;
import javafx.scene.control.TreeTableColumn;
import javafx.scene.control.TreeTableRow;
import javafx.scene.control.TreeTableView;

import javafx.scene.control.TreeView;
import javafx.scene.layout.Pane;
import javafx.util.Duration;

/**
 * FXML Controller class
 *
 * @author Letty
 */
public class RetrieveFileController implements Initializable {

    

   

    /**
     * Initializes the controller class.
     */
  

    
    @FXML
    private TreeTableColumn<File , Date> DateColumn;

    @FXML
    private TreeTableColumn<File, String> NameColumn;

    @FXML
    private TreeTableView<File> RetrieveFileTree;

    @FXML
    private TreeTableColumn<File, File> SizeColumn;

    private final static NumberFormat NumberFormater = NumberFormat.getIntegerInstance();
    private final static DateFormat DateFormater = DateFormat.getDateTimeInstance();
    
     
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
        TreeItem<File> root = createNode(new File("C:\\Users\\Letty\\Desktop\\Prototype\\"));
        root.setExpanded(true);
     
        RetrieveFileTree.setRoot(root);
      
        buildFileBrowserTreeTableView(RetrieveFileTree);
        
        final PseudoClass firstRowClass = PseudoClass.getPseudoClass("first-row");

        RetrieveFileTree.setRowFactory(treeTable -> {
            TreeTableRow<File> row = new TreeTableRow<File>(); 
            row.treeItemProperty().addListener((ov, oldTreeItem, newTreeItem) -> 
                row.pseudoClassStateChanged(firstRowClass, newTreeItem == treeTable.getRoot()));
            return row ;
        });
                 // TODO
                  
    }  
    
    private void buildFileBrowserTreeTableView(TreeTableView<File> RetrieveFileTree) {
       
     
        // --- name column
        NameColumn = new TreeTableColumn<File, String>("Name");
        NameColumn.setPrefWidth(300);
        NameColumn.setCellValueFactory((TreeTableColumn.CellDataFeatures<File, String> p) -> {
            File f = p.getValue().getValue();
            String text = f.getParentFile() == null ? "/" : f.getName();
            return new ReadOnlyObjectWrapper<String>(text);
        });
     
        // --- size column
        SizeColumn = new TreeTableColumn<File, File>("Size");
        SizeColumn.setPrefWidth(100);
        SizeColumn.setCellValueFactory((TreeTableColumn.CellDataFeatures<File, File> p) -> new ReadOnlyObjectWrapper<File>(p.getValue().getValue()));
        SizeColumn.setCellFactory((final TreeTableColumn<File, File> p) -> new TreeTableCell<File, File>() {
            @Override protected void updateItem(File item, boolean empty) {
                super.updateItem(item, empty);
                
                TreeTableView<File> treeTable = p.getTreeTableView();
                
                TreeItem<File> treeItem = treeTable.getTreeItem(getIndex());
                if (item == null || empty || treeItem == null ||
                        treeItem.getValue() == null || treeItem.getValue().isDirectory()) {
                    setText(null);
                } else {
                    setText(NumberFormater.format(item.length()) + " KB");
                }
            }
        });
        SizeColumn.setComparator((File f1, File f2) -> {
            long s1 = f1.isDirectory() ? 0 : f1.length();
            long s2 = f2.isDirectory() ? 0 : f2.length();
            long result = s1 - s2;
            if (result < 0) {
                return -1;
            } else if (result == 0) {
                return 0;
            } else {
                return 1;
            }
        });
     
        // --- modified column
        DateColumn = new TreeTableColumn<File, Date>("Last Modified");
        DateColumn.setPrefWidth(130);
        DateColumn.setCellValueFactory((TreeTableColumn.CellDataFeatures<File, Date> p) -> new ReadOnlyObjectWrapper<Date>(new Date(p.getValue().getValue().lastModified())));
        DateColumn.setCellFactory((TreeTableColumn<File, Date> p) -> new TreeTableCell<File, Date>() {
            @Override protected void updateItem(Date item, boolean empty) {
                super.updateItem(item, empty);
                
                if (item == null || empty) {
                    setText(null);
                } else {
                    setText(DateFormater.format(item));
                }
            }
        });
     
        RetrieveFileTree.getColumns().setAll(NameColumn, SizeColumn, DateColumn);
    }
 
    private TreeItem<File> createNode(final File f) {
        final TreeItem<File> node = new TreeItem<File>(f) {
            private boolean isLeaf;
            private boolean isFirstTimeChildren = true;
            private boolean isFirstTimeLeaf = true;
     
            @Override public ObservableList<TreeItem<File>> getChildren() {
                if (isFirstTimeChildren) {
                    isFirstTimeChildren = false;
                    super.getChildren().setAll(buildChildren(this));
                }
                return super.getChildren();
            }
     
            @Override public boolean isLeaf() {
                if (isFirstTimeLeaf) {
                    isFirstTimeLeaf = false;
                    File f = (File) getValue();
                    isLeaf = f.isFile();
                }
     
                return isLeaf;
            }
        };
       
        return node;
    }
 
    private ObservableList<TreeItem<File>> buildChildren(TreeItem<File> TreeItem) {
        File f = (File) TreeItem.getValue();
        if (f != null && f.isDirectory()) {
            File[] files = f.listFiles();
            if (files != null) {
                ObservableList<TreeItem<File>> children = FXCollections.observableArrayList();
     
                for (File childFile : files) {
                    children.add(createNode(childFile));
                }
     
                return children;
            }
        }
     
        return FXCollections.emptyObservableList();
} 
   

    
}
