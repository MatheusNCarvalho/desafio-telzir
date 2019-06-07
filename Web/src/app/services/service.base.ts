import { environment } from 'src/environments/environment';
import { HttpHeaders } from '@angular/common/http';
import { throwError } from 'rxjs';

export abstract class ServiceBase {
  protected UrlBase: string = environment.urlBaseAPi;

  protected ObterHeaderJson() {
    return {
      headers: new HttpHeaders({
        'Content-type': 'application/json'
      })
    };
  }

  protected extractData(response: any) {

    console.log("ServiceBaseSucces= " + response.data);
    return response.data || {}
  }

  protected serviceError(error: Response | any) {
    console.log("ServiceBaseError= " + error.errors);
    return throwError(error);
  }
}