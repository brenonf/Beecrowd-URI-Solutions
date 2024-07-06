s,t,f = map(int,input().split())

hora = s + t + f

if hora >= 24:
    hora -= 24
if hora <0:
    hora = 24 + hora

print(hora)