n = int(input())
x=list()
for i in range(n):
    x.append(int(input()))

print(len(set(x)))
print(len(x)-len(set(x)))
