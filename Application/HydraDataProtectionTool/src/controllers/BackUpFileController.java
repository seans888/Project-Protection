/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;


import com.jfoenix.controls.JFXButton;
import java.io.File;
import java.io.IOException;
import javafx.fxml.FXML;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.Initializable;

/**
 * FXML Controller class
 *
 * @author Letty
 */
public class BackUpFileController implements Initializable {

    /**
     * Initializes the controller class.
     */
     @FXML
    private JFXButton MSWord;

    @FXML
    private JFXButton Notepad;

    @FXML
    private JFXButton Wordpad;

    @FXML
    private JFXButton MSExcel;

    @FXML
    private JFXButton MSPpt;

    @FXML
    private JFXButton NotepadPlus;

    Process process;
        File file = null;
        File file2 = new File("C:\\Users\\Letty\\Desktop\\Prototype\\SampleDocs");
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    @FXML
    public void msWordBtn (ActionEvent event) throws IOException {
        try {
            process = Runtime.getRuntime().exec("cmd.exe /C start WINWORD.EXE" );
            file = File.createTempFile("Untitled", ".docx", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
    
    public void msPptBtn (ActionEvent event) throws IOException {
       try {
            process = Runtime.getRuntime().exec("cmd.exe /C start POWERPNT.EXE" );
            file = File.createTempFile("Untitled", ".pptx", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
       public void msExcelBtn (ActionEvent event) throws IOException {
       try {
           process = Runtime.getRuntime().exec("cmd.exe /C start EXCEL.EXE" );
            file = File.createTempFile("Untitled", ".xlsx", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        }
       }
       
       public void wordPad (ActionEvent event) throws IOException {
       try {
           process = Runtime.getRuntime().exec("cmd.exe /C start wordpad.EXE" );
            file = File.createTempFile("Untitled", ".rtf", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        
        }
       }
      
    public void notePadPlusBtn (ActionEvent event) throws IOException {
       try {
            process = Runtime.getRuntime().exec("cmd.exe /C start notepad++.EXE" );
            file = File.createTempFile("Untitled", ".ccp", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        }
       }
       
       public void notePadBtn (ActionEvent event) throws IOException {
       try {
            process = Runtime.getRuntime().exec("cmd.exe /C start notepad.EXE" );
            file = File.createTempFile("Untitled", ".txt", file2);
        } catch (IOException ex) {
            Logger.getLogger(BackUpFileController.class.getName()).log(Level.SEVERE, null, ex);
        }
       }
       
    
}
