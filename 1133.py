x = int(input())
y = int(input())

if x > y:
    a = y
    b = x
if x <= y:
    a = x
    b = y
a=a+1
while a < b:
    if a % 5 == 2 or a % 5 == 3:
        print(a)
    a = a + 1
