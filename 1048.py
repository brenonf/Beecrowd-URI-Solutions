x = float(input())
if x <= 400.00:
    s = x * 1.15
    r = s - x
    p = 15
if 400.01 <= x <= 800.00:
    s = x * 1.12
    r = s - x
    p = 12
if 800.01 <= x <= 1200.00:
    s = x * 1.10
    r = s - x
    p = 10
if 1200.01 <= x <= 2000.00:
    s = x * 1.07
    r = s - x
    p = 7
if  x > 2000.00:
    s = x * 1.04
    r = s - x
    p = 4

    
print('Novo salario: {:.2f}'.format(s))
print('Reajuste ganho: {:.2f}'.format(r))
print('Em percentual: {} %'.format(p))
