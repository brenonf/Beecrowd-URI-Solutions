import math

while True:
    n=list(map(int,input().split()))
    if n[0]==0 and n[1]==0 and n[2]==0:
        break;
    print(math.trunc((n[0]*n[1]*n[2])**(1/3)))