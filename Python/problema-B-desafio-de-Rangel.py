n = int(input())
M=[]
m = input().split()
for i in range(n -1):
    for j in range(i+1,n):
        if int(m[i])<int(m[j]):
            M.append(m[j])
            break

    if len(M) < i+1:
        M.append('*')
M.append('*')


m2 = ' '.join(M)
        
print(m2)      
                
        
