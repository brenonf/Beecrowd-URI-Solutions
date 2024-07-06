n = int(input()) + 1

x = list()


for i in range(n):
    cam = input().split()
    for j in range(n):
        cam[j] =int(cam[j])
    x.append(cam)

string =''
for i in range(n - 1):
    for j in range(n - 1):
        s = x[i][j] + x[i][j+1] + x[i+1][j] + x[i+1][j+1]
        if s >= 2:
            string += 'S'
        else:
            string += 'U'
    print(string)
    string =''