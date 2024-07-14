n = int(input())
c = int(input())
pp=set()
for i in range(c):
    a=int(input())
    pp.add(a)
print(n-len(pp))