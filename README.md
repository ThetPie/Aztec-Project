# Aztec-Project
1) Before opening the project, please make sure to copy & paste the two files from "Database File" folder to your SQL Server Folder where your database files are stored.
2) And then, when you can open the project file which is in the "Aztec_Project" folder, you must need to enter into Web.Config file to change the database name in <connectionStrings> tag and you'll see two lines in this tag. However, if you see only a line, copy that line and paste under it and replace the name "DefaultConnection" with "AztecDatabaseEntities".
3) After that, you have to Clean and Rebuild the project, then run the HomeController and when you seee the error message, put "/Home/Start" behind the original URL.
4) Finally, you can see the web page.
