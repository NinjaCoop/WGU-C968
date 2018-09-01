# WGU-C968
Inventory Management program in C#. The requirements are below.
 
I. GUI

A.  A main form, showing the following controls:
•   buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit”
•   lists for parts and products
•   text boxes for searching for parts and products
•   title labels for parts, products, and the application title

B.  An add part form, showing the following controls:
•   radio buttons for “In-House” and “Outsourced” parts
•   buttons for “Save” and “Cancel”
•   text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
•   labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine   ID
 
C.  A modify part form, with fields that populate with pre-saved data, showing the following controls:
•   radio buttons for “In-House” and “Outsourced” parts
•   buttons for “Save” and “Cancel”
•   text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
•   labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID

D.  An add product form, showing the following controls:
•   buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
•   text boxes for ID, name, inventory level, price, and max and min values
•   labels for ID, name, inventory level, price, max and min values, and the application
•   a grid view for associated parts and their products
•   a “Search” button and a text field with an associated list for displaying the results of the search
 
E.  A modify product form, with fields that populate with pre-saved data, showing the following controls:
•   buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
•   text boxes for ID, name, inventory level, price, and max and min values
•   labels for ID, name, inventory level, price, max and min values, and the application
•   a grid view for associated parts and their products
•   a “Search” button and a text box with associated list for displaying the results of the search

II. Application

Now that you’ve created the GUI, write code to create the class structure provided in the attached “UML (unified modeling language) Class Diagram.” Enable each of the following capabilities in the application:

F.  Using the attached “UML Class Diagram,” create appropriate classes and instance variables with the following criteria:
•   five classes with the 16 associated instance variables
•   variables are only accessible through get properties
•   variables are only modifiable through set properties

G.  Add the following functionalities to the main form, using the methods provided in the attached “UML Class Diagram”:
•   redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms
•   delete a selected part or product from the grid view
•   search for a part or product and display matching results
•   exit the main form

H.  Add the following functionalities to the part forms, using the methods provided in the attached “UML Class Diagram”:
1.  “Add Part” form
•   select “In-House” or “Outsourced”
•   enter name, inventory level, price, max and min values, and company name or machine ID
•   save the data and then redirect to the main form
•   cancel or exit out of this form and go back to the main form

2.  “Modify Part” form
•   select “In-House” or “Outsourced”
•   modify or change data values
•   save modifications to the data and then redirect to the main form
•   cancel or exit out of this form and go back to the main form 

I.   Add the following functionalities to the product forms, using the methods provided in the attached “UML Class Diagram”:
1.  “Add Product” form
•   enter name, inventory level, price, and max and min values
•   save the data and then redirect to the main form
•   associate one or more parts with a product
•   remove or disassociate a part from a product
•   cancel or exit out of this form and go back to the main form

2.  “Modify Product” form
•   modify or change data values
•   save modifications to the data and then redirect to the main form
•   associate one or more parts with a product
•   remove or disassociate a part from a product
•   cancel or exit out of this form and go back to the main form

J.   Write code to implement exception controls with custom error messages for one requirement out of each of the following sets (pick one from each):

1.  Set 1
•   preventing the minimum string from having a value other than integers
•   preventing the maximum string from having a value other than integers
•   preventing the minimum field from having a value above the maximum field
•   preventing the maximum field from having a value below the minimum field

2.  Set 2
•   preventing the user from deleting a product that has a part assigned to it
•   including a confirm dialogue for all “Delete” and “Cancel” buttons
•   ensuring that the price of a product cannot be less than the cost of the parts
•   preventing the inventory from having a value other than the integers
