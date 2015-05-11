<?php
class CrossedArt_Mapi_Model_Sales_Order_Api_V2 extends CrossedArt_Mapi_Model_Sales_Order_Api
{
	public function printinfo($warehouse)
	{
 		$oderIdsArr = array();
 		//Switch preparation warehouse ID based on the string chosen in the client application
 		switch ($warehouse)
 		{
 			case "Sweden":
 				$prep_war = 2;
 				break;
 			case "USA":
 				$prep_war = 3;
 				break;
 			case "Denmark":
 				$prep_war = 4;
 				break;
 		}
	
 		$billingAliasName = 'billing_o_a';
 		$shippingAliasName = 'shipping_o_a';
 			
 		
 		// Get collection of all the items accross all warehouses
 		$collection = Mage::getModel('sales/order_item')->getCollection();
 		/* @var $collection Mage_Sales_Model_Mysql4_Order_Item_Collection */
 		//Filter collection based on the warehouse that has been chosen
		$collection->addFieldToFilter('preparation_warehouse', $prep_war);
 		$collection->addFieldToFilter('(qty_invoiced - qty_shipped - qty_refunded)', array('gt' => '0')); 		
	
 		
 		
 		//Go through item collection and get order for each item
 		foreach ($collection as $item)
 		{
 			if ($item->getreserved_qty() == $item->getRemainToShipQty())
 			{
				$order = $item->getOrder();
				if($order->getStatus() == "processing" && $order->getPaymentValidated() == 1)
				{
					if(Mage::helper('mapi')->AddOrderToList($order, $prep_war))
						$orderIdsArr[] = $order->getId();
				}
 			}
 		}
 		
 		$uniqueIdsArr[] = array_unique($orderIdsArr);
 		$orderCollection = Mage::getModel('sales/order')->getCollection()->addAttributeToFilter('entity_id', array('in' => $uniqueIdsArr));
 		
 		$billingFirstnameField = "$billingAliasName.firstname";
 		$billingLastnameField = "$billingAliasName.lastname";
 		$shippingFirstnameField = "$shippingAliasName.firstname";
 		$shippingLastnameField = "$shippingAliasName.lastname";
 		$orderCollection->addAttributeToSelect('*')->addAddressFields()
	 		->addExpressionFieldToSelect('shipping_firstname', "{{shipping_firstname}}", array('shipping_firstname' => $shippingFirstnameField))
	 		->addExpressionFieldToSelect('shipping_lastname', "{{shipping_lastname}}", array('shipping_lastname' => $shippingLastnameField))
	 		->addExpressionFieldToSelect('shipping_name', "CONCAT({{shipping_firstname}}, ' ', {{shipping_lastname}})", array('shipping_firstname' => $shippingFirstnameField, 'shipping_lastname' => $shippingLastnameField))
	 		->addExpressionFieldToSelect('company', "{{company}}", array('company' => $shippingAliasName . '.company'))
	 		->addExpressionFieldToSelect('street', "{{street}}", array('street' => $shippingAliasName . '.street'))
	 		->addExpressionFieldToSelect('city', "{{city}}", array('city' => $shippingAliasName . '.city'))
	 		->addExpressionFieldToSelect('postcode', "{{postcode}}", array('postcode' => $shippingAliasName . '.postcode'))
	 		->addExpressionFieldToSelect('region', "{{region}}", array('region' => $shippingAliasName . '.region'))
	 		->addExpressionFieldToSelect('country_id', "{{country_id}}", array('country_id' => $shippingAliasName . '.country_id')
	 	);
 		
 		foreach ($orderCollection as $order) {
 			$orders[] = $this->_getAttributes($order, 'order'); 			
 		}
 		return $orders;
	}
	
	public function detail($orderIncrementId)
	{
		$order = $this->_initOrder($orderIncrementId);
	
		if ($order->getGiftMessageId() > 0) {
			$order->setGiftMessage(
					Mage::getSingleton('giftmessage/message')->load($order->getGiftMessageId())->getMessage()
			);
		}
	
		$result = $this->_getAttributes($order, 'order');
	
		$result['shipping_address'] = $this->_getAttributes($order->getShippingAddress(), 'order_address');
		$result['billing_address']  = $this->_getAttributes($order->getBillingAddress(), 'order_address');
		$result['items'] = array();
	
		foreach ($order->getAllItems() as $item) {
			if ($item->getGiftMessageId() > 0) {
				$item->setGiftMessage(
						Mage::getSingleton('giftmessage/message')->load($item->getGiftMessageId())->getMessage()
				);
			}
	
			$result['items'][] = $this->_getAttributes($item, 'order_item');
		}
	
		$result['payment'] = $this->_getAttributes($order->getPayment(), 'order_payment');
	
		$result['status_history'] = array();
	
		foreach ($order->getAllStatusHistory() as $history) {
			$result['status_history'][] = $this->_getAttributes($history, 'order_status_history');
		}
	
		return $result;
	}
}