import sys, getopt                                                     
from blackstripes import spiral                                        
                                                                       
outputFile = "/mnt/c/Users/Dave"                                           
inputFile = "/mnt/c/Users/Dave"                                            
nibSize = 2                                                            
color = "#000000"                                                      
scale = 1                                                              
levels = [180,108,180,108]                                             
spacing = 2                                                            
                                                                       
argv = sys.argv[1:]
opts, args = getopt.getopt(argv, "i:o:n:f:s:l::::p:m:")
for opt, arg in opts:                                                  
        if opt == "-i":
                inputFile = inputFile + '/{}'.format(arg)
        if opt  == "-o":                                               
                outputFile = outputFile + '/{}'.format(arg)
        if opt == "-n":                                                
                nibSize = int(arg)
        if opt == "-f":                                                
                color = arg
        if opt == "-s":                                                
                scale = float(arg)
        if opt == "-l":
                levels =  list(map(int,arg.split(',')))
        if opt == "-p":
                spacing = int(arg)
                                                                       
spiral.draw(inputFile,        
            outputFile,       
            nibSize,                                                 
            color,                                             
            scale,                                                    
            levels[0],levels[1],levels[2],levels[3],                                   
            spacing,           
            1024,1024,0.1                                            
)

