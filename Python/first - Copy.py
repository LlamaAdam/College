states  = {"alabama": "montgomery" , "alaska": "juneau" , "arizona": "phoenix" , "arkansas": "little rock",
 "california": "sacramento" , "colorado": "denver" , "connecticut": "hartford" , "delaware": "dover",
 "florida": "tallahassee" , "georgia": "atlanta" , "hawaii": "honolulu" , "idaho": "boise",
 "illinois": "springfield" , "indiana": "indianapolis" , "iowa": "des moines" , "kansas": "topeka",
 "kentucky": "frankfort" , "louisiana": "baton rouge" , "maine": "augusta" , "maryland": "annapolis",
 "massachusetts": "boston" , "michigan": "lansing" , "minnesota": "st. paul" , "mississippi": "jackson",
 "missouri": "jefferson city","montana": "helena" , "nebraska": "lincoln" , "nevada": "carson city",
 "new hampshire": "concord" , "new jersey": "trenton" , "new mexico": "santa fe" , "new york": "albany",
 "north carolina": "raleigh" , "north dakota": "bismarck" , "ohio": "columbus" , "oklahoma": "oklahoma city",
 "oregon": "salem" , "pennsylvania": "harrisburg" , "rhode island": "providence" , "south carolina": "columbia",
 "south dakota": "pierre" , "tennessee": "nashville" , "texas": "austin" , "utah": "salt lake city",
 "vermont": "montpelier" , "virginia": "richmond" , "washington": "olympia" , "west virginia": "charleston",
 "wisconsin": "madison" , "wyoming": "cheyenne"}


user=input("Please enter the of a state for the capital").lower()
x=0
for akey in states.keys():
    if user == akey:
        print("The capital of", akey.title() , "is", states[akey].title())
        x=1

if x!= 1:
    print("An error has occured please make sure", user.title(), "is a valid choice.")