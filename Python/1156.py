s=0
j = 1
for i in range(1,40,2):
    s = float(s + i / j)
    j = j * 2
print('{:.2f}'.format(s))
