n=input()
fila=list(map(int,input().split()))
n = input()
desistentes=set(map(int, input().split()))
fila=[x for x in fila if x not in desistentes]
print(" ".join(map(str, fila)))
