# This was made by Adam Cox on 7/27/2019
# It looks at the crimes in various states
# Reads an external file and outputs the results

def data(x):        #This reports back the name and number of crimes
    a=x.split(",")
    if a[11].isdigit():
        y = int(a[11]) + int(a[12])
        values = a[10], y
        return values


def main():
    fileref=open("state_crime - CS152.csv","r")
    outfile=open("crime_summary.txt","w")
    state = {}
    # Print the table
    for c in fileref:       #Looks at each line of the file
        z = data(c)
        if z is None:       #None on the first line so use that to make the header
            s="State"
            r="Reported Crimes"
            sr= s.ljust(25) + r.rjust(15)
            outfile.write(sr + '\n')
        else:
            if z[0] in state:   #If state is there crimes are added
                state[z[0]] += z[1]
            else:               #If state isnt there it adds the state and first crime
                state.update({z[0]: z[1]})
    for x in sorted (state.keys()): #This sorts the list and makes it write each file
        if x !="United States":
            st = x.ljust(25)
            num = " {:,}".format(state[x])
            num = num.rjust(15)
            outfile.write(st + num + '\n')

        if x == "Wyoming":
            st = "United States".ljust(25)
            num = " {:,}".format(state["United States"])
            num = num.rjust(15)
            outfile.write(st + num + '\n')


    fileref.close()
    outfile.close()

main()
