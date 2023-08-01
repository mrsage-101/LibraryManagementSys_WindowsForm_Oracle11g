# LibraryManagementSys_WindowsForm_Oracle11g

System Requirements
We will focus on the following set of requirements while designing the Library Management System:
1. Any library member should be able to search books by their title, author, subject category as well
by the publication date.
2. Each book will have a unique identification number and other details including a rack number
which will help to physically locate the book.
3. There could be more than one copy of a book, and library members should be able to check-out
and reserve any copy. We will call each copy of a book, a book item.
4. The system should be able to retrieve information like who took a particular book or what are the
books checked-out by a specific library member.
5. The system must provide a comprehensive racks system to manage the books in the Libaray.
Each category of book has a rack number and on that rack number of at least 5 sections against
each book.(example: The rack of the name Computer science and there are different sections of
books like Database , Computer Networks)
6. There should be a maximum limit (5) on how many books a member can check out.
7. There should be a maximum limit (10) on how many days a member can keep a book.
8. The system should be able to collect fines for books returned after the due date.
9. Members should be able to reserve books that are not currently available.
10. The system should be able to send notifications whenever the reserved books become available, as
well as when the book is not returned within the due date.
11. Each book and member card will have a unique barcode. The system will be able to read barcodes
from books and members’ library cards.

---------------------------------------------------------------------------------

Top functionalities of the LMS
• Add/Remove/Edit book: To add, remove or modify a book or book item.
• Search catalog: To search books by title, author, subject or publication date and show the position
of books(Return Section with respective Rack No.)
• Register new account/cancel membership: To add a new member or cancel the membership of
an existing member.
• Check-out book: To borrow a book from the library.
• Reserve book: To reserve a book which is not currently available.
• Renew a book: To reborrow an already checked-out book.
• Return a book: To return a book to the library which was issued to a member.

--------------------------------------------------------------------------------

Basic & Advanced SQL queries (Mandatory):
A group will be evaluated on following SQL & PL/SQL queries which will be evaluated as compulsory
part of project. Note: (This will trace an obvious understanding of DML, DDL and DCL)
1. Basic use SQL select, where, order by clause. (Evaluation bucket criteria: 40%)
2. Use of having clause with multivalued functions. (Evaluation bucket criteria: 15%)
3. Use of Join to show various reports. (Evaluation bucket criteria: 15%)
4. Implementation of Normalization, PL/SQL and SQL attributed function. (Evaluation bucket criteria:
25% each)
5. Hieratical implementation of SQL users through DCL (Evaluation bucket criteria: 5%)
• SQL (DDL, DML, DCL, Grouping, Nested queries, joins, Views, Indexing, Built-in functions)
• PL/SQL (Conditional statements, Loops, Procedures/Functions/Packages, Triggers, Cursors)
