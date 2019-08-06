<?php
require_once "includes/ps/PagSeguroLibrary/PagSeguroLibrary.php";
class CreatePaymentRequestLightbox {

public static function main() {
    $form = $_GET['form'];
    $id_transfer = $_POST["id_transfer"];
    $id = $_POST["id_saida"];
    $nome = $_POST["nome_produto"];
    $valor   = $_POST["valor_final"];
    $v1 ="teste";

    $paymentRequest = new PagSeguroPaymentRequest();
    $paymentRequest->setCurrency("BRL");
    $paymentRequest->addItem($v1, 'Notebook prata', 1, 430.00);
    $paymentRequest->setReference("REF123");
    $sedexCode = PagSeguroShippingType::getCodeByType('SEDEX');
    $paymentRequest->setShippingType($sedexCode);
    $paymentRequest->setShippingAddress(
        '01452002',
        'Av. Brig. Faria Lima',
        '1384',
        'apto. 114',
        'Jardim Paulistano',
        'São Paulo',
        'SP',
        'BRA'
    );
    $paymentRequest->setSender(
        'João Comprador',
        'email@comprador.com.br',
        '11',
        '56273440',
        'CPF',
        '156.009.442-76'
    );
    $paymentRequest->setRedirectUrl("http://www.lojamodelo.com.br");
    $paymentRequest->addMetadata('PASSENGER_CPF', '15600944276', 1);
    $paymentRequest->addMetadata('GAME_NAME', 'DOTA');
    $paymentRequest->addMetadata('PASSENGER_PASSPORT', '23456', 1);
    $paymentRequest->addParameter('notificationURL', 'http://www.lojamodelo.com.br/nas');
    $paymentRequest->addParameter('senderBornDate', '07/05/1981');
    $paymentRequest->addIndexedParameter('itemId', '0003', 3);
    $paymentRequest->addIndexedParameter('itemDescription', 'Notebook Preto', 3);
    $paymentRequest->addIndexedParameter('itemQuantity', '1', 3);
    $paymentRequest->addIndexedParameter('itemAmount', '200.00', 3);
    try {
        $credentials = new PagSeguroAccountCredentials("fabioh.rangel@gmail.com",
            "EDC2E4A8E6B246D29C713FB97C26808E");
        $onlyCheckoutCode = true;
        $code = $paymentRequest->register($credentials, $onlyCheckoutCode);
        self::printPaymentUrl($code);
    } catch (PagSeguroServiceException $e) {
        die($e->getMessage());
    }
  }

  public static function printPaymentUrl($code) {
    if ($code) {
        echo "<h2>Criando requisi&ccedil;&atilde;o de pagamento</h2>";
        echo "<p>Code: <strong>$code</strong></p>";
        echo "<script>
        PagSeguroLightbox('".$code."');
              </script>";
    }
  }
 }
}
CreatePaymentRequestLightbox::main();

//https://pt.stackoverflow.com/q/52649/101
