import { ServiceBase } from './service.base';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable()
export class PromocaoFaleMaisService extends ServiceBase {
  public constructor(private http: HttpClient) {
    super();
  }

  public verCalculos(): Observable<any[]> {
    return this.http
      .get<any[]>(this.UrlBase + 'v1/fale-mais/ver-calculos', super.ObterHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError)
      );
  };

  public calcularPromocao(obj: any): Observable<any> {
    return this.http
      .post(this.UrlBase + 'v1/fale-mais/calcular-ligacoes', obj, super.ObterHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError)
      );
  };
}