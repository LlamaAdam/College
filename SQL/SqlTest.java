/*
   Program Name: CreateTable.java
   Done by: Adam Cox
 */

import java.sql.*;
import java.util.Scanner;

public class SqlTest {

	static final String URL = "jdbc:mariadb://localhost:3306/fordis5";

	public static void main(String args[]) {

	    Scanner stdIn = new Scanner(System.in);
		String user;
		String password;
		Connection con = null;
		Statement stmt = null;

		String createString = "create table WebPublished  " +
							  "( ArticleID VARCHAR(7) PRIMARY KEY," +
							  "Website TEXT," +
							  "PublishedDate DATETIME)" ;

        System.out.println("Enter MariaDB username:");
        user = stdIn.nextLine();
        System.out.println("Enter password:");
        password = stdIn.nextLine();


		try {
			Class.forName("org.mariadb.jdbc.Driver");

		} catch(java.lang.ClassNotFoundException e) {
			System.err.print("ClassNotFoundException: ");
			System.err.println(e.getMessage());
		}

		try {
			con = DriverManager.getConnection(URL, user, password);

			stmt = con.createStatement();
   		    stmt.executeUpdate(createString);

			stmt.close();
			con.close();

		} catch(SQLException ex) {
			System.err.println("SQLException: " + ex.getMessage());
		}
	}
}

