<?php
class Markov_Sentence_Generator
{ 
    private $mapping;
    private $starts;
    
    private function parse_file(string $file_name):array 
    {
        // I'm gonna parse the file, and then hash'em 
        $str = $this->fixCaps(file_get_contents($file_name));
        preg_match_all('/\w+\\W|\\s\n+/', $str, $list);
        return $list;
    }
    private function hasupper(string $word): bool
    {
        $str = str_split($word);
        foreach($str as $char)
        {
            if(ctype_upper($char))
            {
                return true;
            } 
        }
        return false;
    }
    private function fixCaps(string $word): string
    {
        if($this->hasupper($word) && $word != "I") 
        {
            return strtolower($word);
        }
        return $word;
    }
    public function __construct($file_name)
    {
        $this->mapping = $this->parse_file($file_name);
        $this->starts = 0;
    }
    public function generate_phrase()
    {
        $string = [];
        for($i = 0; $i < 5; ++$i) {
            for($j = 0; $j < 5; ++$j) {
                $key = rand($this->starts, (count($this->mapping[0])) - 2);
                $left  = $this->mapping[0][$key];
                $key = rand($this->starts, count($this->mapping[0]) - 1);
                $right = $this->mapping[0][$key];
                if((rand(0, 100) * 0.01) < 0.3) {
                    $string[] = $left;
                } else {
                    $string[] = $right;
                }
            }
        }
        return implode(' ', $string);
    }
}

$mg = new Markov_Sentence_Generator('file.txt');
echo($mg->generate_phrase());
