/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import com.jfoenix.controls.JFXTextArea;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.URL;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.chart.PieChart;
import javafx.scene.chart.PieChart.Data;
import javax.swing.filechooser.FileSystemView;

/**
 * FXML Controller class
 *
 * @author Letty
 */
public class MemCheckController implements Initializable {

    /**
     * Initializes the controller class.
     */
     @FXML
    private JFXTextArea MemCheckOutput;
    @FXML
    private PieChart MemCheckPieGraph;

    FileSystemView fsv = FileSystemView.getFileSystemView();
    File file = new File("C:/");
    DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
    DateFormat dateFormatSave = new SimpleDateFormat("EEE_d_MMM_yyyy");
    Date date = new Date();
    int gb = 1024*1024*1024;  
    //Text Area
    double TotalSpace = (int) (file.getTotalSpace()/gb);
    double UsableSpace = (int) (file.getUsableSpace()/gb);
    double FreeSpace = (int) (TotalSpace - UsableSpace);
    double percent = (int)((FreeSpace/TotalSpace)* 100);
    //For Pie Graph
    double MemoryUsed = (int)(UsableSpace * 100);
    double FreeStorage = (int) (FreeSpace * 100);
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        //Pie Graph
        MemCheckPieGraph.setData(getChartData());
        MemCheckPieGraph.isVisible();

        //Text Area
        MemCheckOutput.setText("Drive Letter: " + file + 
                "\nType: " + fsv.getSystemTypeDescription(file) + 
                "\nTotal space: " + TotalSpace + " GB" +
                "\nUsed space: " + UsableSpace + " GB" +
                "\nFree space: " + FreeSpace +  " GB" +
                "\nPercent: " +  percent +  "%" + 
                "\nTimestamp: " + dateFormat.format(date));
        
               
               String ScannedLogs = MemCheckOutput.getText();
            try {
                 PrintWriter MemScanLogs = new PrintWriter (new FileWriter ("C:\\Users\\Letty\\Desktop\\Prototype\\SampleLogs\\Logs " + dateFormatSave.format(date) + ".txt" , true));
                 MemScanLogs.println(ScannedLogs)  ;
               
               MemScanLogs.close();
                  System.out.println("File Saved");
            } catch (IOException ex) {
                Logger.getLogger(MemCheckController.class.getName()).log(Level.SEVERE, null, ex);
            }
        
    }    
    
    public ObservableList<Data> getChartData() {
        ObservableList<Data> answer = FXCollections.observableArrayList();
        answer.addAll(new PieChart.Data("Memory Used", MemoryUsed),
                      new PieChart.Data("Free Storage", FreeStorage));
        return answer;
        
         
    }
}
