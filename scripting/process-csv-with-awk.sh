#!/bin/sh
# this script will process a csv file and extract info to a separate file

# Extract all cities from the data set
awk -F, '{ print $2 }' all-locations.csv > cities.txt

# Extract the list of unique cities from the data set
awk -F, '{ print $2 }' all-locations.csv | sort | uniq > unique-cities.txt

# Extract the list of Polish cities from the data set
awk -F, '$3=="Poland" { print $2 }' all-locations.csv | sort | uniq > polish-cities.txt

# Download the data set from the internet and extract only Female customers
filename='all-customers.csv'
curl "https://api.mockaroo.com/api/a9b2b840?count=1000&key=df449e20" > $filename
awk -v FS=, -v OFS=, '$5=="Female" { name=$2" "$3; print $1,name }' $filename > female-customers-only.csv