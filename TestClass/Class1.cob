       IDENTIFICATION DIVISION.
       CLASS-ID. CLASS-1 AS "TestClass.Class1".
       ENVIRONMENT DIVISION.
       CONFIGURATION SECTION.
       SPECIAL-NAMES.
       REPOSITORY.
           CLASS CLASS-STRING AS "System.String"
           .
       OBJECT.
       
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
       
           Select OPTIONAL HistFile
               Assign to hID
               Organization is relative access mode is dynamic
               relative key is hRelkey  file status is hStatus.
      *        Lock mode is MANUAL with lock on MULTIPLE RECORDS.
               
       
       DATA DIVISION.
       
       File SECTION.
          
       FD  HistFile.
       COPY TSFDHIST.
       
       WORKING-STORAGE SECTION.
       
       01  hRelkey          PIC 9(8) COMP-5.
       01  hStatus          pic 9(2) value zero.
       01  hID              pic x(255) value space.
       01  hOpenSW          pic 9 comp-5 value zero.     
         
       PROCEDURE DIVISION.
      
       METHOD-ID. READHISTORY AS "ReadHistory".
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  wChar            pic x value space.
       01  WS-EOF           pic A(1).
       
       LINKAGE SECTION.
       01  ret                  OBJECT REFERENCE CLASS-STRING.
       01  historyFile          OBJECT REFERENCE CLASS-STRING.
      
       PROCEDURE DIVISION USING BY VALUE historyFile  RETURNING ret.
           SET hID to historyFile
           set ret to "finished"    
           if hOpenSW = ZERO
               open input HistFile
               move 1 to hOpenSW
           END-IF    
               move 1 to hRelkey 
               start histFile key = hRelkey
                 invalid KEY    
                   move "Y" to ws-eof
                   CLOSE HistFile
                   move zero to hOpenSW    
               end-start 
           
           PERFORM until WS-EOF = "Y"   
               READ HistFile next record at end 
                   MOVE "Y" to WS-EOF
      *                CLOSE HistFile
                       exit method
               END-READ
           END-PERFORM
       END METHOD READHISTORY.
       
       METHOD-ID. CREATEHISTORY AS "CreateHistory".
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  wChar            pic x value space.
       01  WS-EOF           pic A(1).
       
       LINKAGE SECTION.
       01  historyFile          OBJECT REFERENCE CLASS-STRING.
      
       PROCEDURE DIVISION USING BY VALUE historyFile.
           SET hID to historyFile
           if hOpenSW = ZERO
               open output HistFile
           END-IF
           move zero to hrelkey
           perform until hRelkey = 10000000
               add 1 to    hRelkey
               MOVE zero            to histGen
               MOVE hRelkey         to histSub
               MOVE 2               to histInv
               MOVE 3               to histDate
               MOVE 4               to histRef
               MOVE 5               to histJr
               MOVE 6               to histIntroUser
               MOVE 7               to histIntroDate
               MOVE "Description"   to histDesc
               MOVE 8.99            to histAmt
               MOVE "Extra"         to histExtra
               write histRec
               end-write
           END-PERFORM.
      
           close HistFile
           move zero to hOpenSW         
       END METHOD CREATEHISTORY.
       END OBJECT.
      
       END CLASS CLASS-1.