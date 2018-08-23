n = int(input())
c = 0
r = 0
s = 0

for i in range(1 , n + 1):
    x = input().split()
    a, b, = x
    if b == 'C':
        c = c + int(a)
    if b == 'R':
        r = r + int(a)
    if b == 'S':
        s = s + int(a)

total = c + r + s
pc = (c / total) * 100
pr = (r / total) * 100
ps = (s / total) * 100

print('Total: {} cobaias'.format(total))
print('Total de coelhos: {}'.format(c))
print('Total de ratos: {}'.format(r))
print('Total de sapos: {}'.format(s))
print('Percentual de coelhos: {:.2f} %'.format(pc))
print('Percentual de ratos: {:.2f} %'.format(pr))
print('Percentual de sapos: {:.2f} %'.format(ps))
