<?php
class CrossedArt_Mapi_Helper_Data extends Mage_Core_Helper_Data
{
	public function AddOrderToList($order, $warehouseId)
	{
		$totalRemained = 0;
		$totalReserved = 0;
		
		foreach ($order->getAllItems() as $item)
		{
			if($warehouseId != $item->getPreparationWarehouse()) continue;
			$stockItem = Mage::getModel('cataloginventory/stock_item')->loadByProductWarehouse($item->getProductId(), $warehouseId);
			if ($stockItem)
			{
				if ($stockItem->getManageStock())
				{
					if($item->getReservedQty() >= 5) return true;
					$totalReserved += $item->getReservedQty();
					$totalRemained += $item->getRemainToShipQty();
				}
			}
		}
		
		if($totalReserved >= 5) return true;
		else if($totalRemained >= 2 && $order->getCountryId() == "AU") return true;
		else if($totalReserved >= $totalRemained) return true;
		else return false;
	}
}