p=3.141592654
import math
while True:
    try:
        a,b,c=list(map(float,input().split()))
        h=math.tan(a*p/180)*b
        print(f'{5*(h+c):.2f}')
    except EOFError:
        break