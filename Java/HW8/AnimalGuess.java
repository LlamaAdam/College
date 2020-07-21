/****************************************
* AnimalGuess.java
* <Adam Cox>
*
* This is the AnimalGuesser
****************************************/

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.*;
import java.util.*;

public class AnimalGuess extends Application
{
		private final String[] animals = new String[] {  // All the animals
				"sheep","ant","lion","tiger","yak"
				};
		private int index = 0;							 // Array Counter

		//***************************************************************

		// This runs the intro window

		public void start(Stage stage)
		{
			GridPane pane = new GridPane();
			Scene scene = new Scene(pane);
			Button btn = new Button("Ok");							 // Button for starting game
			Label intro = new Label("How good is your memory?\n"
					+ "Try to memorize this sequence of animals:\n"
					+ "sheep ant lion tiger yak");

			stage.initStyle(StageStyle.UTILITY);
			scene.getStylesheets().add("animal.css");
	        pane.add(intro, 0, 0, 5, 5);
	        pane.add(btn, 6, 6);
			btn.setOnAction(new EventHandler<ActionEvent>()
	        {
	            @Override
	            public void handle(ActionEvent event) {
	            	theGame();
	            	stage.close();
	            }
	        });
			stage.setTitle("Animal Memory Game");
			stage.setScene(scene);
			stage.show();
	    } // end of start

//***************************************************************

		// This runs the actual game

		private void theGame()
		{
			final String[] prompts = new String[] {					// Array for Questions
					"Enter animal number 1" , "Enter animal number 2" ,
					"Enter animal number 3" , "Enter animal number 4" ,
					"Enter animal number 5" };
			Stage stage2 = new Stage();
			Label prompt = new Label(prompts[0]);
			String[] data = new String[5];
			TextField dataBox = new TextField();
			FlowPane pane = new FlowPane(prompt, dataBox);
			Scene scene = new Scene(pane);

			stage2.initStyle(StageStyle.UTILITY);
			scene.getStylesheets().add("animal.css");
			dataBox.getStyleClass().add("dataBox");
			stage2.setTitle("Animal Memory Game");
			stage2.setScene(scene);
			stage2.show();
			dataBox.setOnAction(e ->{
				data[index] = dataBox.getText();
				dataBox.setText("");
				if (!data[index].equals(animals[index]))		// Compares answer and ends game
				{
					dataBox.setVisible(false);
					prompt.getStyleClass().add("fontSize");
					prompt.setText("Sorry - wrong animal!");

					dataBox.setOnAction(null);
				}
				else if (index < data.length-1)
				{
					index++;
					prompt.setText(prompts[index]);
				}
				else
				{
					dataBox.setVisible(false);
					prompt.getStyleClass().add("fontSize");
					prompt.setText("Congratulations - your memory is perfect!");
				}
				}); // end of databox action

		} // end of the game

} // end of AnimalGuess