       IDENTIFICATION DIVISION.
       CLASS-ID. CLASS-1 AS "TestClass2.Class1".
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
       
           Select OPTIONAL HistFile2
               Assign to hID2
               Organization is relative access mode is dynamic
               relative key is hRelkey2  file status is hStatus2.
      *        Lock mode is MANUAL with lock on MULTIPLE RECORDS.
               
           Select OPTIONAL dayFile
               Assign to dID
               Organization is indexed access mode is dynamic
               record key is daykey1 
               alternate key is daykey2 with duplicates
               alternate key is dayKey3a, daykey3b, daykey3c
                                        with duplicates  
               file status is dStatus     
               Lock mode is manual with lock on MULTIPLE RECORDS.
               
       DATA DIVISION.
       
       File SECTION.
          
       FD  HistFile2.
       COPY TSFDHIST.
       
       FD  dayFile.
       COPY TSFDDAY.
       
       WORKING-STORAGE SECTION.
       
       01  hRelkey2          PIC 9(8) COMP-5.
       01  hStatus2          pic 9(2) value zero.
       01  hID2              pic x(255) value "C:\Sam\MFG.h10".   *> "C:\SAM\mfg.h10".
       01  hOpenSW2          pic 9 comp-5 value zero.     
         
         
       01 dStatus.
         02  dStatus1           pic x value space.
         02  dStatus2           pic x value space. 
       01  dID                  pic x(255) value "C:\TRS\trs.Day".
       01  dOpenSW              pic 9 comp-5 value zero.  
       
         
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
           SET hID2 to historyFile
           set ret to "finished"    
           if hOpenSW2 = ZERO
               open input HistFile2
           END-IF    
               move 1 to hOpenSW2
               move 1 to hRelkey2 
               start histFile2 key = hRelkey2
                 invalid KEY    
                   move "Y" to ws-eof
                   CLOSE HistFile2
                   move zero to hOpenSW2    
               end-start 
           
           PERFORM until WS-EOF = "Y"   
               READ HistFile2 next record at end 
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
           SET hID2 to historyFile
           if hOpenSW2 = ZERO
               open output HistFile2
           END-IF
           move zero to hrelkey2
           perform until hRelkey2 = 10000000
               add 1 to    hRelkey2
               MOVE zero            to histGen
               MOVE hRelkey2        to histSub
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
      
           close HistFile2
           move zero to hOpenSW2         
       END METHOD CREATEHISTORY.
       
       
       METHOD-ID. CONVERTHISTORYDAY AS "ConvertHistoryDay".
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       
       
       01  WS-histRec.
         02  WS-histKey.
           03  WS-histGen         PIC 9(5).
           03  WS-histSub         PIC 9(12).
           03  WS-histDate        PIC 9(8).
           03  WS-histRef         PIC 9(9).
           03  WS-histJr          PIC 9(3).
         02  WS-histInv           PIC 9(12).
         02  WS-histAmt           PIC S9(12)V99.
         02  WS-histDesc          PIC X(20).
         02  WS-histExtra         PIC X(5).
         02  WS-histIntroUser     PIC 9(3).
         02  WS-histIntroDate     PIC 9(8).
       
       
       
       01 WS-CountOff PIC 9(9) COMP-5 VALUE ZERO.
       
           
       01  WS-EOF               pic A(1).
       01  wDayRow              pic 9(9) value ZERO.
       
       LINKAGE SECTION.
       01  temp                 OBJECT REFERENCE CLASS-STRING.
       01  ret                  OBJECT REFERENCE CLASS-STRING.
       01  historyFilePath      OBJECT REFERENCE CLASS-STRING.
       01  dayFilePath          OBJECT REFERENCE CLASS-STRING.
       
       PROCEDURE DIVISION USING BY VALUE historyFilePath, dayFilePath RETURNING ret.
           MOVE zero to WS-CountOff
           SET hID2 to historyFilePath
           SET dID to dayFilePath
           
           if hOpenSW2 = ZERO
               open INPUT HistFile2
               open OUTPUT DayFile
           END-IF
           MOVE zero TO hRelkey2
           PERFORM until WS-EOF = "Y"
               add 1 to hRelkey2
               add 1 to wDayRow
               add 1 to WS-CountOff
               READ HistFile2 RECORD INTO WS-histRec
               INVALID KEY
                   MOVE "Y" to WS-EOF
               NOT INVALID KEY
      *            move hRelkey to wDayRow
                   move 1   to dayUser
                   move hRelkey2         to dayRow 
                   move WS-histGen  to dayGen
                   move WS-histSub  to daySub 
                   move WS-histInv  to dayInv 
                   move WS-histDate to dayDate 
                   move WS-histRef  to dayRef 
                   move WS-histJr   to dayJr 
                   move WS-histIntroUser to dayIntroUser 
                   move WS-histIntroDate to dayIntroDate 
                   move WS-histAmt   to dayAmt
                   move WS-histDESC  to dayDesc
                   move WS-histExtra to dayExtra
      
      *            move histGen  to dayGen
      *            move histSub  to daySub 
      *            move histInv  to dayInv 
      *            move histDate to dayDate 
      *            move histRef  to dayRef 
      *            move histJr   to dayJr 
      *            move histXLink to dayXLink 
      *            move histIntroUser to dayIntroUser 
      *            move histIntroDate to dayIntroDate 
      *            move histAmt   to dayAmt
      *            move histDESC  to dayDesc
      *            move histExtra to dayExtra
      *            move histSeq to daySeq
                   
                   write dayRec
                   end-write
      *            if wDayRow = 2
      *                exit PERFORM
      *            END-IF
                   
               END-READ
      
           END-PERFORM.
           
      *    SUBTRACT 1 from hRelkey
      * Set record zero SUB field to the total amount of records for this user
           move 1                   to dayUser
           move 0                   to dayRow
           move 0                   to dayGen
           move hRelkey2             to daySub
           move 0                   to dayDate
           move 0                   to dayRef
           move 0                   to dayJr
           move 0                   to dayAmt
           move 0                   to dayInv
           move space               to dayDesc
           move space               to dayExtra
           move 0                   to dayIntroUser
           move 0                   to dayIntroDate
           write dayRec
           end-write
               
                   
           CLOSE HistFile2.
           CLOSE DayFile.
           move zero to hOpenSW2.
       
       END METHOD CONVERTHISTORYDAY.
       
       
       METHOD-ID. READDAY AS "ReadDay".
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  ss               OBJECT REFERENCE CLASS-STRING.
      
       01  wChar            pic x value space. 
       01  WS-EOF           pic A(1).
       01  WS-NUMERICamt    pic S9(12)V99.
       01  tCount           pic 9(9) value ZERO.
       
       LINKAGE SECTION.
       01  startposition    PIC S9(9) COMP-5. *>OBJECT REFERENCE CLASS-STRING.
       01  endposition      PIC S9(9) COMP-5. *>OBJECT REFERENCE CLASS-STRING.
       01  ret              OBJECT REFERENCE CLASS-STRING.
       01  dayFilePath      OBJECT REFERENCE CLASS-STRING.
       
       PROCEDURE DIVISION USING BY VALUE dayFilePath, startposition, endposition.
           SET dID to dayFilePath
           if dOpenSW = ZERO
               open INPUT DayFile
           END-IF
           move low-value to dayRec
           START DAYFILE KEY is not < dayKey1
             invalid key
               move "Y" to WS-EOF
               close DayFile
               move zero to dOpenSW
               exit method         
           end-start
           perform until WS-EOF = "Y"
               move 1 to DayUser
               move 1 to DayRow
               READ DAYFILE next record at END
                   MOVE "Y" to WS-EOF
                   exit perform 
               end-read
               add 1 to tCount 
      *         SET ss to dtoobjectLIST::"Add" (dtoobject)
           end-perform
           CLOSE DayFile
           move zero to dOpenSW
           .
                    
       END METHOD READDAY.
       
       END OBJECT.
      
       END CLASS CLASS-1.