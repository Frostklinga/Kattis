https://open.kattis.com/problems/buildinghighways

There are N cities.
Each city has problems which is denoted with certain levels.
A certain city denoted with i has a problem level of A. Denoted as Ai.

Going to build highways.
Problematic cities tend to hinder that.
Estimation based on problematic difficulty connecting i-th city and j-th city is Ai + Aj.

The highways should be built as following:

- From any city someone can go to any other cities using the built highways
- Minimize the sum of difficulty (Problematic cities) building the highways between cities.

Input: 
First line an integer N (1 <= N <= 200 000)
Next line N integers Ai (1 <= Ai <= 1 000 000)

Output:
Minimum sum of all the difficulty level to build the highways

A city has all other N as neighbours.
Calculate the difficulty for all the neighbours.
Sort that and you have the difficulty levels.

Then: All cities should connect.

Look at the lowest difficulty then the next.