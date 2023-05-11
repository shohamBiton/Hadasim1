import math
def printShape():
     shape = int(input("תפריט: הקש 1 לבחירת מגדל מלבן, ו-2 עבור מגדל משולש. --ליציאה מהתוכנית הקש 3--"))
     while shape==1 or shape==2:
         height=int(input("הקש גובה המגדל"))
         width=int(input("הקש רוחב המגדל"))
         if shape==1:
             print("שטח המרובע:" , width*height) if max(width,height)-min(width,height)>5 else print("היקף המרובע:" , width*2+height*2)
             print(("*"*width+"\n")*height)
         elif shape==2:
             if max(width,height)-min(width,height)>5:
                 shok=math.sqrt(((width/2)**2)+(height**2))
                 print("היקף המשולש:",shok*2+width)
             else:
                 print("שטח המשולש:",(width*height)/2)
             if width%2==0 or width>height*2:
                 print("לא ניתן להדפיס את המשולש")
             else:
                 printRectangle(width,height)
         shape = int(input("תפריט: הקש 1 לבחירת מגדל מלבן, ו-2 עבור מגדל משולש. --ליציאה מהתוכנית הקש 3--"))




def printRectangle(base,height):
    oddNumsAmount=(base-2)//2
    rowsNumforEachOdd=(height-2)//oddNumsAmount
    extraRowsNumOf3=height-2-(rowsNumforEachOdd*oddNumsAmount)
    starsNum=1
    blank=" "*((base-starsNum)//2)
    rec=blank+"*"*starsNum+"\n"
    for i in range(3,base,2):
        starsNum=i
        blank = " "*((base - starsNum) // 2)
        if starsNum==3:
            rec+=((blank+"*"*starsNum)+"\n")*(extraRowsNumOf3+rowsNumforEachOdd)
        else:
            rec+=((blank+"*"*starsNum)+"\n")*rowsNumforEachOdd
    rec+="*"*base
    print(rec)

printShape()
