       01  dayRec.  
         02  dayKey1.
           04  dayUser         pic 9(3).
           04  dayRow          pic 9(7).
         02  dayData.
           04  dayKey2.  
             06  dayKey3a.
               08  dayGen        PIC 9(5).   
               08  daySub        PIC 9(12).  
             06  dayKey3c.
               08  dayDate       PIC 9(8).   
               08  dayRef        PIC 9(9).   
               08  dayJr         PIC 9(3).   
           04  dayKey3b.  
             06  dayInv          PIC 9(12).  
           04  dayAmt            PIC S9(12)V99. 
           04  dayDesc           PIC X(20).
           04  dayExtra          PIC X(5).
           04  dayIntroUser      PIC 9(3).  
           04  dayIntroDate      PIC 9(8).   
               
