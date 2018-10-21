import sys, getopt                                         
from blackstripes import sketchy                           
                                                           
outputFile = "/mnt/c/Users/Dave"                           
inputFile = "/mnt/c/Users/Dave"                            
nibSize = 2                                                
color = "#000000"                                          
scale = 1                                                  
levels = [180,108,180,108]                                 
lineSize = 2                                               
maxLineLength = 100                                        
argv = sys.argv[1:]                                        
opts, args = getopt.getopt(argv, "i:o:n:f:s:l:m:")         
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
                lineSize = int(arg)                        
        if opt == "-m":                                    
                maxLineLength = int(arg)                   
sketchy.draw(inputFile,                                    
            outputFile,                                    
            nibSize,                                       
            maxLineLength,                                 
            color,                                         
            scale,                                         
            lineSize,                                      
            0,0,0.0                                        
)                                                          

