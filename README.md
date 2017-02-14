### Task: Cairne's Auto ###


Cairn’s Automotive performs the following routine maintenance services:
        • Oil change—€26.00
        • Lube job—€18.00
        • Radiator flush—€30.00
        • Transmission flush—€80.00
        • Inspection—€15.00
        • Muffler replacement—€100.00
        • Tyre rotation—€20.00

Cairns also performs other non-routine services and charges for parts and labour (€20 per hour).

Create an application that will:


 Display the total for a customer’s visit to Cairns.

 Store all the summary information that was generated when the “Calculate” button was
   pressed, in a file called “all_receipts.txt”.

 The file “all_receipts.txt” should record the current summery information and retain
   summery information from earlier transactions.

 Display all the summary details stored in “all_receipts.txt” when the “Receipts” button is
   pressed. (You decide how/where this information will be displayed)

 Handle unexpected errors. (Invalid inputs, file not found etc.) 

 Follow good programming conventions for object names: include comments for some
   methods and at the top of the file to explain what the application is about.

 Give the form a name that will display at the top of the form.

 Include code to help the user to identify invalid inputs errors.

 Use currency formatting to display the results in euros.

 Include your name in the bottom right corner “Programmed by …………….”

 Include screenshots showing the application in use.

 Include screenshots showing the application recovering from invalid input errors.

The application should have the following value-returning methods:

        • OilLubeCharges —Returns the total charges for an oil change and/or a lube job, if any.
        • FlushCharges —Returns the total charges for a radiator flush and/or a transmission flush, if
          any.
        • MiscCharges —Returns the total charges for an inspection, muffler replacement, and/or a
          tyre rotation, if any.
        • OtherCharges —Returns the total charges for other services (parts and labour), if any.
        • TaxCharges —Returns the amount of sales tax, if any. Sales tax is 23% and is charged only
          on parts. If the customer purchases services only, no sales tax is charged.
        • TotalCharges —Returns the total charges

The application should have the following void methods, called when the user clicks the Clear
button:

        • ClearOilLube —Clears the check boxes for oil change and lube job.
        • ClearFlushes —Clears the check boxes for radiator flush and transmission flush.
        • ClearMisc —Clears the check boxes for inspection, muffler replacement, and tyre rotation.
        • ClearOther —Clears the text boxes for parts and labour.
        • ClearFees —Clears the labels that display the labels in the section marked Summary
        