import { ResponseModel } from './responseModels';
import { Product } from './product';
export interface ProductResponseModel extends ResponseModel {
    data: Product[],

}
