import { Model } from '../../lib/mooadmin-ngx';

export interface Food extends Model {
    id: number;
    name: string;
    type: string;
    calories: number;
    created: Date;
}
