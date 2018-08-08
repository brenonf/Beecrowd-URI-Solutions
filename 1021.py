n = float(input())

n100 = n // 100
n = n - n100*100

n50 = n // 50
n = n - n50*50

n20 = n // 20
n = n - n20*20

n10 = n // 10
n = n - n10*10

n5 = n // 5
n = n - n5*5

n2 = n // 2
n = n - n2*2

n1 = n // 1
n = n - n1*1
n1=float('%.2f'% n1)
n=float('%.2f'% n)

m50 = n // 0.5
n = n - m50*0.5
m50=float('%.2f'% m50)
n=float('%.2f'% n)

m25 = n // 0.25
n = n - m25*0.25
m25=float('%.2f'% m25)
n=float('%.2f'% n)

m10 = n // 0.10
n = n - m10*0.10
m10=float('%.2f'% m10)
n=float('%.2f'% n)

m5 = n // 0.05
n = n - m5*0.05
m5=float('%.2f'% m5)
n=float('%.2f'% n)

m1 = n * 100
m1=float('%.2f'% m1)
n=float('%.2f'% n)

print('NOTAS:')
print('{} nota(s) de R$ 100.00'.format(int(n100)))
print('{} nota(s) de R$ 50.00'.format(int(n50)))
print('{} nota(s) de R$ 20.00'.format(int(n20)))
print('{} nota(s) de R$ 10.00'.format(int(n10)))
print('{} nota(s) de R$ 5.00'.format(int(n5)))
print('{} nota(s) de R$ 2.00'.format(int(n2)))
print('MOEDAS:')
print('{} moeda(s) de R$ 1.00'.format(int(n1)))
print('{} moeda(s) de R$ 0.50'.format(int(m50)))
print('{} moeda(s) de R$ 0.25'.format(int(m25)))
print('{} moeda(s) de R$ 0.10'.format(int(m10)))
print('{} moeda(s) de R$ 0.05'.format(int(m5)))
print('{} moeda(s) de R$ 0.01'.format(int(m1)))
