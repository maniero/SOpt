function calcularIMC() {  
    var estilo = document.getElementById("estilo").value; 
    var experiencia = document.getElementById("experiencia").value; 
    var altura = document.getElementById("altura").value; 
    var peso = document.getElementById("peso").value; 
    var imc = 0;  
    if (altura > 0 && peso > 0) {
        imc = peso / (altura * altura);
    }
    if (estilo == "StandUp Paddle") {  
        if (experiencia >=3) {   
            if (imc<=29) {   
                alert("SUP SURF");                 
            } else { 
                alert("FUNBOARD");                
            }
        } else { 
            alert("Alguma mensagem pra quem não tem experiência suficiente");
        }
    } else if (estilo == "Surf") {            
         if (imc <= 25) {          
             alert("PRANCHINHA");  
         } else {         
             alert("LONGBOARD");        
         }
    }
}

<span>Estilo</span><br>
<select name="estilo" id="estilo" value="estilo" required>
   <option disabled selected hidden>Escolha seu estilo</option>
   <option>StandUp Paddle</option>
   <option>Surf</option>
</select><br><br>

<span>Experiência</span><br>
  <select name="experiencia" id="experiencia" required>
  <option disabled selected hidden>Escolha sua experiência</option>
  <option value="0">sem experiência</option>
  <option value="1">menos de 1 mês</option>
  <option value="2">até 3 meses</option>
  <option value="3">até 6 meses</option>
  <option value="4">1 ano ou mais</option>
</select>  <br> <br>


<span>Altura</span><br>
<select name="altura" id="altura" required>
  <option disabled selected hidden>Escolha sua altura</option>
  <option>1.60</option>
  <option>1.61</option>
  <option>1.62</option>
  <option>1.63</option>
  <option>1.64</option>
  <option>1.65</option>
  <option>1.66</option>
  <option>1.67</option>
  <option>1.68</option>
  <option>1.69</option>
  <option>1.70</option>
  <option>1.71</option>
  <option>1.72</option>
  <option>1.73</option>
  <option>1.74</option>
  <option>1.75</option>
  <option>1.76</option>
  <option>1.77</option>
  <option>1.78</option>
  <option>1.79</option>
  <option>1.80</option>
  <option>1.81</option>
  <option>1.82</option>
  <option>1.83</option>
  <option>1.84</option>
  <option>1.85</option>
  <option>1.86</option>
  <option>1.87</option>
  <option>1.88</option>
  <option>1.89</option>
  <option>1.90</option>
  <option>1.91</option>
  <option>1.92</option>
  <option>1.93</option>
  <option>1.94</option>
  <option>1.95</option>
  <option>1.96</option>
  <option>1.97</option>
  <option>1.98</option>
  <option>1.99</option>
  <option>2.00</option> 
</select><br><br>


<span>Peso</span><br>
<select name="peso" id="peso" required>
  <option disabled selected hidden>Escolha seu peso</option>
  <option>50</option>
  <option>51</option>
  <option>52</option>
  <option>53</option>        
  <option>54</option>
  <option>55</option>
  <option>56</option>
  <option>57</option>
  <option>58</option>
  <option>59</option>
  <option>60</option>
  <option>61</option>
  <option>62</option>
  <option>63</option>
  <option>64</option>
  <option>65</option>
  <option>66</option>
  <option>67</option>
  <option>68</option>
  <option>69</option>
  <option>70</option>
  <option>71</option>
  <option>72</option>
  <option>73</option>
  <option>74</option>
  <option>75</option>
  <option>76</option>
  <option>77</option>
  <option>78</option>
  <option>79</option>
  <option>80</option>
  <option>81</option>
  <option>82</option>
  <option>83</option>
  <option>84</option>
  <option>85</option>
  <option>86</option>
  <option>87</option>
  <option>88</option>
  <option>89</option>
  <option>90</option>
  <option>91</option>
  <option>92</option>
  <option>93</option>
  <option>94</option>
  <option>95</option>
  <option>96</option>
  <option>97</option>
  <option>98</option>
  <option>99</option>
  <option>100</option>
</select><br><br>

    
 <button id="Enviar" onclick="calcularIMC();">Send</button>
 
 //https://pt.stackoverflow.com/q/124475/101
