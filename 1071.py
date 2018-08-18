x = int(input())
y = int(input())
s=0
if x < y:
    a = x
    b = y
else:
    a = y
    b = x

for i in range(a+1,b):
    if i % 2 != 0:
        s = s + i
print(s)
