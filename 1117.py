i = 0
med = 0
while i < 2:
    nota = float(input())
    if nota >= 0 and nota <= 10:
        i = i + 1
        med = med + nota
    if nota < 0 or nota > 10:
        print('nota invalida')
med = med / 2
print('media = {:.2f}'.format(med))
