/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import com.jfoenix.controls.JFXDrawer;
import com.jfoenix.controls.JFXHamburger;
import com.jfoenix.transitions.hamburger.HamburgerBackArrowBasicTransition;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.URL;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.zip.ZipOutputStream;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.control.MenuBar;
import javafx.scene.control.MenuItem;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;


/**
 *
 * @author Letty
 */
public class MainController implements Initializable {
    
     @FXML
    private JFXDrawer navDrawer;

    @FXML
    private AnchorPane root;

    @FXML
    private JFXHamburger navHamburger;
     @FXML
    private MenuItem LogsDownload;
     
    @FXML
    private MenuBar MainMenuBar;
    
    public static AnchorPane rootPane;
    public static JFXDrawer navDrawerPane;
    public static JFXHamburger navHamburgerOption;
    public static MenuBar mainMenuBarOption;
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
       rootPane = root;
       navDrawerPane = navDrawer;
       navHamburgerOption = navHamburger;
       mainMenuBarOption = MainMenuBar;
       
        try {
             // TODO
             HBox navBox = FXMLLoader.load(getClass().getResource("/views/SideNav.fxml"));
             navDrawer.setSidePane(navBox);
             } catch (IOException ex) {
             Logger.getLogger(MainController.class.getName()).log(Level.SEVERE, null, ex);
         }
      
           HamburgerBackArrowBasicTransition transition = new HamburgerBackArrowBasicTransition(navHamburger);
             transition.setRate(-1);
             navHamburger.addEventHandler(MouseEvent.MOUSE_PRESSED,(e)->{
                 transition.setRate(transition.getRate()*-1);
                 transition.play();
             
                 if(navDrawer.isShown())
                 {
                     navDrawer.close();
                 }else
                     navDrawer.open();
             });
               
    }  
    
     
    @FXML
    public void logsDownload(ActionEvent event) {
        DateFormat dateFormatSave = new SimpleDateFormat("EEE_d_MMM_yyyy");
         Date date = new Date();    
         File f = new File("C:\\Users\\Letty\\Desktop\\Prototype\\SampleLogs " + dateFormatSave.format(date) +".zip");
             try (ZipOutputStream out = new ZipOutputStream(new FileOutputStream(f))) {
                 System.out.println("File Saved");
            } catch (IOException ex) {
                Logger.getLogger(MainController.class.getName()).log(Level.SEVERE, null, ex);
            }

    }
    
}
