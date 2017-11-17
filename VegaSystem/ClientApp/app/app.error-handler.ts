import * as Raven from 'raven-js'; 
import { ToastyService } from 'ng2-toasty';
import { ErrorHandler, Inject, NgZone, isDevMode } from '@angular/core';

export class AppErrorHandler implements ErrorHandler {
  constructor(
    @Inject(ToastyService) private toastyService: ToastyService, @Inject(NgZone) private zone: NgZone) {
  }

  handleError(error: any): void {
    // this.zone.run(() => {
    //   this.toastyService.error({
    //     title: 'Error',
    //     msg: 'An unexpected error happened.',
    //     theme: 'bootstrap',
    //     showClose: true,
    //     timeout: 5000
    //   });
    // });

    // if (!isDevMode()) {
    //   Raven.captureException(error.originalError || error);
    // } else {
    //   throw error;
    // }
  }
}