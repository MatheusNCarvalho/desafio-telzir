import { ServiceBase } from './service.base';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


@Injectable()
export class TarifasSerivce extends ServiceBase {

  public constructor(private http: HttpClient) {
    super();
  }
 

  public getDestinos(ddddId: string): Observable<any[]> {
    return this.http
      .get<any[]>(this.UrlBase + `v1/tarifas/ddds-prdestinos?ddddId=${ddddId}`, super.ObterHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError)
      );
  };
}