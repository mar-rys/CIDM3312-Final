Final Project for CIDM 3312

Web Application: ColorGoGo
Description and Purpose: ColorGoGo is a web application designed to track orders for a small business that sells coloring books. The application tracks which artists drew coloring books, associates them with the correct customers, and updates the status of orders. The purpose of this application is to associate artists with their coloring book, track inventory, and fulfill customers’ orders. 
Data: 
Entity: Artist
Attributes: ArtistID (PK), ArtistName, Email, ColoringBooks, Bio
Entity: ColoringBook
Attributes: ColoringBookID (PK), BookTitle, Price, Theme, ArtistID (FK)
Entity: Customer
Attribute: CustomerID (PK), CustomerName, Address
Entity: Order
Attribute: OrderID (PK), OrderDate, Status, Quantity, ColorBookID, CustomerID (FK)
Relationship: 
1. Artist to ColoringBook: one-to-many 
	One artist can have many coloring books associated with them, but each book has to have at least one artist.  
2. Customer to Order: one-to-many
	A Customer can place many orders, but each order belongs to exactly one customer.  
3. ColoringBook to Order: one-to-many
	A coloring book can appear in many different orders. 

ERD and Business Rules
1. A coloring book can’t be deleted if it’s linked to an existing order; it must be marked with an IsActive Boolean set to hide it from new customers.
2. An order must have a quantity of at least 1 and an order date that is not set in the future. 
3 A single order can’t exceed a quantity of 30 units, so that it won’t be a fraudulent order. 
4. If a customer is deleted, all their orders must be deleted or anonymized. 
5. An order status can only be moved in one direction: pending, printing, shipped, or delivered. 
6. The search bar must allow for partial matches.
