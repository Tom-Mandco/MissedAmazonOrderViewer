select * 
from mackays.pos_channel_orders pco
where pco.source_channel = 2
and pco.order_status = 6
and pco.order_date > sysdate -10
and not exists (select 1 from mackays.web_amz_shipped_audit wasa where wasa.order_number = pco.order_number and wasa.status = 0 )
and pco.order_number not like 'R%'
and pco.order_number not like 'E%'