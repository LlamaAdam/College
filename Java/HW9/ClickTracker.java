/****************************************
* ClickTracker.java
* <Adam Cox>
*
* This is for clicking buttons
****************************************/

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.*;
import java.util.*;

public class ClickTracker extends Application
{

	public static void main(String[] args) {
        launch(args);
    }

	//***************************************************************

	// This makes the window.
	public void start(Stage stage)
	{
		GridPane pane = new GridPane();
		Scene scene = new Scene(pane);

		scene.getStylesheets().add("clicker.css");
		createContents(pane);
		stage.setTitle("Click Tracker");
		stage.setScene(scene);
		stage.show();
	} // end of start

	//***************************************************************

	// This fills the ClickBox

	private void createContents(GridPane pane)
	{
		Button btn;
		Label colHead;
		int cell = 1;			// This is used to number each cell
		final int COLS = 3;		// This sets the number of columns

		for (int colCount = 0; colCount < COLS; colCount++)
		{
			colHead = new Label(Character.toString((char) ('A' + colCount)) );
			pane.add(colHead, colCount, 0);
			for (int rowCount = 0; rowCount < COLS; rowCount++)
			{
				btn = new Button(String.valueOf(cell));
				btn.setOnAction(e ->{
					((Labeled) e.getSource()).setText("Clicked!");
				});
				pane.add(btn, rowCount, colCount+1);
				cell++;
			} // row loop
		} // column loop
	} // end of createContents
} // end of ClickTraker