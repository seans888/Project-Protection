/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import com.jfoenix.controls.JFXButton;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;

import javafx.scene.layout.Pane;

/**
 * FXML Controller class
 *
 * @author Letty
 */
public class SideNavController implements Initializable {

    /**
     * Initializes the controller class.
     */
    @FXML
    private JFXButton fileScan;

    @FXML
    private JFXButton backUp;

    @FXML
    private JFXButton memStat;

    @FXML
    private JFXButton retrieve;

    @FXML
    private JFXButton home;
    Pane MemCheckPane;
    Pane RetrievePane;
    Pane BackUpPane;
    Pane HomePane;

    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
    @FXML
    public void memStatBtn(ActionEvent event) throws IOException {
               this.MemCheckPane = new Pane();
               MemCheckPane = FXMLLoader.load(getClass().getResource("/views/MemCheck.fxml"));
               controllers.MainController.rootPane.getChildren().add(MemCheckPane);
               controllers.MainController.rootPane.getChildren().remove(HomePane);
               controllers.MainController.rootPane.getChildren().remove(RetrievePane);
               controllers.MainController.rootPane.getChildren().remove(BackUpPane);
               controllers.MainController.navDrawerPane.toFront();
               controllers.MainController.navHamburgerOption.toFront();


    }
    
      @FXML
    public void retrieveBtn(ActionEvent event) throws IOException {
            this.RetrievePane = new Pane();
               RetrievePane = FXMLLoader.load(getClass().getResource("/views/RetrieveFile.fxml"));
               controllers.MainController.rootPane.getChildren().add(RetrievePane);
               controllers.MainController.rootPane.getChildren().remove(MemCheckPane);
               controllers.MainController.rootPane.getChildren().remove(BackUpPane);
               controllers.MainController.rootPane.getChildren().remove(HomePane);
               controllers.MainController.navDrawerPane.toFront();
               controllers.MainController.navHamburgerOption.toFront();

    }
    
    @FXML
    public void backUpBtn (ActionEvent event) throws IOException {
            this.BackUpPane = new Pane();
               BackUpPane = FXMLLoader.load(getClass().getResource("/views/BackUpFile.fxml"));
               controllers.MainController.rootPane.getChildren().add(BackUpPane);
               controllers.MainController.rootPane.getChildren().remove(RetrievePane);
               controllers.MainController.rootPane.getChildren().remove(MemCheckPane);
                controllers.MainController.rootPane.getChildren().remove(HomePane);
               controllers.MainController.navDrawerPane.toFront();
               controllers.MainController.navHamburgerOption.toFront();

    }
    
    @FXML
    public void homeBtn(ActionEvent event) throws IOException {
               this.HomePane = new Pane();
               HomePane = FXMLLoader.load(getClass().getResource("/views/Home.fxml"));
               controllers.MainController.rootPane.getChildren().add(HomePane);
               controllers.MainController.rootPane.getChildren().remove(BackUpPane);
               controllers.MainController.rootPane.getChildren().remove(RetrievePane);
               controllers.MainController.rootPane.getChildren().remove(MemCheckPane);
               controllers.MainController.navDrawerPane.toFront();
               controllers.MainController.navHamburgerOption.toFront();

        
    }

    
    
    
    
}
