# Notes Management System

This Windows Forms project is designed to help users manage their notes efficiently. The system allows users to create, view, edit, and delete notes. It provides a user-friendly interface for managing notes stored in a SQL Server database.

## Features

- **Create Note**: Users can create new notes by providing a title and content.
- **View Note**: Users can view existing notes with their titles, content, and creation timestamps.
- **Edit Note**: Users can edit the title and content of existing notes.
- **Delete Note**: Users can delete notes they no longer need.
- **Export Note**: Users can export notes as text files for external storage or sharing.

## Technologies Used

- **C#**: The project is developed using C# programming language.
- **Windows Forms**: The user interface is built using Windows Forms for easy interaction.
- **SQL Server**: Notes are stored and managed in a SQL Server database.
- **ADO.NET**: Data access is handled using ADO.NET libraries for database connectivity.

## Getting Started

1. Clone the repository to your local machine.
2. Open the solution file (`NotesManagement.sln`) in Visual Studio.
3. Build the solution to restore dependencies.
4. Ensure that you have access to a SQL Server instance. Modify the connection string in the code to match your SQL Server instance.
5. Run the application to start managing your notes.

## Usage

1. **Home Page**: Upon launching the application, you'll see the home page displaying existing notes.
2. **Create Note**: Click on the "New Note" button to create a new note. Provide a title and content for the note, then click "Save".
3. **View Note**: Click on the "Open" button next to a note to view its details.
4. **Edit Note**: In the note details view, modify the title or content as needed, then click "Save".
5. **Delete Note**: To delete a note, open its details and click the "Delete" button.
6. **Export Note**: Click on the "Export" button to export a note as a text file.
