while True:
    try:
        teste = input()
        if not teste:
            break

        n =int(teste)
        EHD=0
        EPR=0
        intruso=0

        for i in range(n):
            input_str=input().split()[1]
            if input_str=="EHD":
                EHD+=1
            elif input_str == "EPR":
                EPR+=1
            else:
                intruso+=1
        
        print(f"EPR: {EPR}")
        print(f"EHD: {EHD}")
        print(f"INTRUSOS: {intruso}")
    except EOFError:
        break
