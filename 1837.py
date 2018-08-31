a,b =map(int,input().split())
m=max(abs(a),abs(b))


for q in range(-m,m+1):
    for r in range(-b,b+1):
        if a == b * q + r:
            quo = q
            res = r
            break
print(quo,res)


    
