import { Injectable } from '@angular/core';
import { ActiveRecord, ApiConfig } from '../../../lib/mooadmin-ngx';
import { SampleData } from './sample-data';
import { Http } from '@angular/http';

@Injectable()
export class SampleDataService extends ActiveRecord<SampleData> {
  constructor(public options: ApiConfig, public http: Http) {
    super(options, http, 'sample-data');

  }
}
