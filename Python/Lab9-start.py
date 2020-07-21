# This program was made by Adam Cox on 7/20/2019
# Open and read health data file one line at a time
# Columns are 
#   disease,increase,location,number,population,year


def add(x):             #Displays the result and adds to the total
    st = values[2].ljust(21)
    disease = values[0].ljust(14)
    number = int(values[4])
    x = x + number
    number=" {:,}".format(int(number)).rjust(10)
    record.append(st + disease + number + year)
    print(st, disease, number, year)
    return x


file = open("health-no-head.csv", "r")
us=input("Enter state (Empty means all): ").upper()     #User inputs choices that are changed to uppercase
ud=input("Enter disease (Empty means all): ").upper()
uy=input("Enter year (Empty means all): ")
record=[]
total=0
print("State                 Disease            Number     Year")
# Process each line of the file
for aline in file:              #Checked every line of the file
    values = aline.split(',')
    state=values[2]
    year=values[5].rstrip()
    if state.startswith(us) and values[0]==ud and year==uy:
        total=add(total)
    if (us=='') or (ud=='') or (uy==''):        #For when the user presses enter on an input
        if us=='':
            if values[0] == ud and year == uy:
                total=add(total)
            elif ud==''and year==uy:
                total=add(total)
            elif uy==''and values[0]==ud:
                total=add(total)
            elif (us=='') and (ud=='') and (uy==''):
                total=add(total)
        elif ud=='':
            if state.startswith(us) and year == uy:
                total=add(total)
            elif uy=='' and state.startswith(us):
                total=add(total)
        elif uy=='':
            if state.startswith(us) and values[0] == ud:
                total=add(total)

total=" {:,}".format(int(total))    #formats the number
a=46-len(total)
print("TOTAL         ".rjust(a),total)  #shows the sum of the diseases
# Close file
file.close()

