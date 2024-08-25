For the Simple Contact Management System, the database can be designed with two main tables: Users and Contacts. Here's a basic outline of the database schema and the relationships between these tables:

Database Tables
Users

UserId (Primary Key, int): Unique identifier for each user.
Username (nvarchar, 100): The username for login.
PasswordHash (nvarchar, 256): Hashed password for user authentication.
Email (nvarchar, 200): The user's email address.
CreatedDate (datetime): Date and time when the user account was created.
Contacts

ContactId (Primary Key, int): Unique identifier for each contact.
UserId (Foreign Key, int): The identifier linking the contact to a specific user.
Name (nvarchar, 200): The name of the contact.
PhoneNumber (nvarchar, 15): The phone number of the contact.
Email (nvarchar, 200): The email address of the contact.
Notes (nvarchar, 1000): Additional notes about the contact.
CreatedDate (datetime): Date and time when the contact was added.

Explanation
Users Table: Stores information about the users who can log in to the system. The UserId serves as the primary key.
Contacts Table: Stores the details of each contact associated with a user. The UserId field acts as a foreign key, linking each contact to the user who created it.
This simple schema ensures that each user can manage their own set of contacts independently, with basic authentication to protect user data.
