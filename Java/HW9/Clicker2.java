/****************************************
* Clicker.java
* <Adam Cox>
*
* This is the Click Button
****************************************/

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.*;
import java.util.*;

public class Clicker2 extends Application
{
	private final int rows = 3;
	public int cell = 1;

	public void start(Stage stage)
	{
		GridPane pane = new GridPane();
		Scene scene = new Scene(pane);

		createContents(pane);
		stage.setTitle("Click Tracker");
		stage.setScene(scene);
		stage.show();
	}

	private void createContents(GridPane pane)
	{
		Button btn;
		Label row;

		for (int colCount = 0; colCount < rows; colCount++)
		{
			pane.add(new Label("row"), colCount, 0);
			for (int rowCount = 0; rowCount < rows; rowCount++)
			{
					pane.add(new Button(String.valueOf(cell)), rowCount, colCount+1);
					cell++;
					System.out.println("rowCount is ="+rowCount);

			}
		}
	}
}