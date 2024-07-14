a,b,c = list(map(int,input().split()))
A,B,C= list(map(int,input().split()))
cont=0
if a<A:
    cont+=A-a
if b<B:
    cont+=B-b
if c<C:
    cont+=C-c
print(cont)