x = input().split()
a, b, c = x

maiorAB = (int(a) + int(b) + abs(int(a) - int(b)))/2
m = (int(c) + (maiorAB) + abs(int(c) - (maiorAB)))/2
m = int(m)
print('{} eh o maior'.format(m))
