l={
'a':'.-',
'b':'-...',
'c':'-.-.',
'd':'-..',
'e':'.',
'f':'..-.',
'g':'--.',
'h':'....',
'i':'..',
'j':'.---',
'k':'-.-',
'l':'.-..',
'm':'--',
'n':'-.',
'o':'---',
'p':'.--.',
'q':'--.-',
'r':'.-.',
's':'...',
't':'-',
'u':'..-',
'v':'...-',
'w':'.--',
'x':'-..-',
'y':'-.--',
'z':'--..',
' ': '.......'}

L = dict()

for i,j in l.items():
    l[i] = l[i].replace('.......',' ')
    l[i] = l[i].replace('-','===,')
    l[i] = l[i].replace('.','=.')
    l[i] = l[i][0:-1]
    l[i] = l[i].replace(',','.')
for i,j in l.items():
    L[j] = i

n = int(input())
for i in range(n):
    frase =''
    cod = input().split('...')
    for j in cod:
        if len(j)>0 and j[0] == '.':
            j =j[1:]
        frase += L[j]
    print(frase)
