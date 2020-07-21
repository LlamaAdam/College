/*
   Program Name: CreateTable.java
   Done by: Adam Cox
 */

import java.sql.*;
import java.util.Scanner;

public class AdamCoxJava3 {

	static final String URL = "jdbc:mariadb://localhost:3306/assig05";

	public static void main(String args[]) {

	    Scanner stdIn = new Scanner(System.in);
		String user;
		String password;
		Connection con = null;
		Statement stmt = null;

		String createString1 = "CREATE TABLE client (ClientID varchar(7) NOT NULL, Name text DEFAULT NULL, LegalAddress text DEFAULT NULL, Phone text DEFAULT NULL, PRIMARY KEY (ClientID))";
		String createString2 = "CREATE TABLE contract (ContractNo varchar(7) NOT NULL, ClientID varchar(7) DEFAULT NULL, IsLongTerm tinyint(1) DEFAULT NULL, PRIMARY KEY (ContractNo), KEY FK_Contract_to_Client (ClientID), CONSTRAINT FK_Contract_to_Client FOREIGN KEY (ClientID) REFERENCES client (ClientID))";
		String createString3 = "INSERT INTO client VALUES ('145696S','Sarah Silverston','PO Box 4622 Delaware 19707','555-555-0008'),('156836P','Joy Behar','PO Box 687 Delaware 19706','555-555-0007'),('278544C','Chris Rock','PO Box 354 Delaware 19703','555-555-0002'),('394204C','Conan Brian','PO Box 34344 Delaware 19707','555-555-0009'),('472507P','Charles Chaplin','PO Box 9587 Delaware 19707','555-555-0010'),('736533Q','Jay Leno','PO Box 216 Delaware 19702','555-555-0004'),('765256P','Eddie Murphee','PO Box 4287 Delaware 19703','555-555-0003'),('842471P','Whopie Goldberg','PO Box 884 Delaware 19706','555-555-0006'),('865263C','Wanda Sykes','PO Box 56944 Delaware 19706','555-555-0005'),('933256Q','Jerry Seinfeld','PO Box 12221 Delaware 19702','555-555-0001')";
		String createString4 = "INSERT INTO contract VALUES ('CO0010','933256Q',0),('CO0011','278544C',1),('CO0012','765256P',0),('CO0013','736533Q',1),('CO0014','865263C',1),('CO0015','842471P',0),('CO0016','156836P',1),('CO0017','145696S',0),('CO0018','394204C',1),('CO0019','472507P',0)";

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
   		    stmt.executeUpdate(createString1);
   		    stmt.executeUpdate(createString2);
			stmt.executeUpdate(createString3);
			stmt.executeUpdate(createString4);
			stmt.close();
			con.close();

		} catch(SQLException ex) {
			System.err.println("SQLException: " + ex.getMessage());
		}
	}
}

