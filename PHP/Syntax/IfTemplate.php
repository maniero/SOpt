<?php if($transaction->status == "refunded"): ?> //isto provavelmente está errado, mas foi colocado errado, não sei qual deva ser o certo
    <td><span class="badge badge-danger">Rembolsado</span></td>
<?php else: ?>
    <?php if ($transaction->paid == 1): ?>
        <td><span class="badge badge-success">Entregue</span></td>
    <?php else: ?>
        <td><span class="badge badge-warning">Pendente</span></td>
    <?php endif; ?>
<?php endif; ?>

//https://pt.stackoverflow.com/q/396631/101
