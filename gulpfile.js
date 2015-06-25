var gulp = require('gulp');
var exec = require('child_process').exec;

gulp.task('watch', function () {
   exec('cd /Users/carlschrammel/Documents/code/BowlingKata');
   gulp.watch('./**/*.cs', ['test']);
}); 

gulp.task('test', function(cb) { 
 
    exec('cd /Users/carlschrammel/Documents/code/BowlingKata');
    
    exec('/Users/carlschrammel/.dnx/runtimes/dnx-mono.1.0.0-beta4/bin/dnx . test',
    {timeout: 8000, killSignal: 'SIGTERM',} ,
        function (err, stdout, stderr) {
            console.log(stdout);        
            console.log(stderr);
            cb(err);
        }
    ); 
});